from login_app import app
from flask import render_template, redirect, request, session
from flask_bcrypt import Bcrypt
from login_app.models.user import User
#Python\flask_mysql\validation\another_project
bcrypt = Bcrypt(app)

@app.route('/')
def index():
    if "user_id" in session:
        return redirect('/dashboard')

    return render_template('index.html')

@app.route('/register', methods=['POST'])
def register():
    if not User.validate_registration(request.form):
        return redirect('/')
    
    hashed_password = bcrypt.generate_password_hash(request.form['passwordInput'])

    data = {
        "first_name" : request.form["fnameInput"],
        "last_name" : request.form["lnameInput"],
        "email" : request.form["emailInput"],
        "password" : hashed_password
    }

    session['user_id'] = User.save(data)
    return redirect('/')

@app.route('/login', methods=['POST'])
def login():
    login_validation = User.validate_login(request.form)
    #returns user's ID, false otherwise
    if not login_validation:
        return redirect('/')
    #set session to user's ID
    session["user_id"] = login_validation
    return redirect('/dashboard')

@app.route('/dashboard')
def dashboard():
    if 'user_id' not in session:
        return redirect('/')

    data = {
        "id" : session["user_id"]
    }

    logged_in_user = User.get_user_by_id(data)

    if logged_in_user == False:
        return redirect('/')

    return render_template("dashboard.html", user = logged_in_user)

@app.route('/logout')
def logout():
    session.clear()
    return redirect('/')