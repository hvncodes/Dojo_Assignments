from flask import render_template,redirect,request,session
from flask_app import app
from flask_app.models.user import User

@app.route("/")
def index():
    users = User.get_all()
    print(users)
    return render_template("index.html", all_users=users)

@app.route('/new')
def new_user_form():
    return render_template("create.html")

@app.route('/create_user', methods=["POST"])
def create_user():
    data = {
        "first_name": request.form["fname"],
        "last_name" : request.form["lname"],
        "email" : request.form["email"]
    }
    # print(data)
    id = User.save(data) # thankfully this returns lastrowid (most recently created user)
    return redirect(f"/users/{id}")

@app.route('/users/<url_id>')
def showOneUser(url_id):
    data = {
        "id": url_id,
    }
    user = User.getOne(data)
    # print(user.id)
    # user = User.getOne(data)[0]
    # print(user)
    # print(user["id"])
    return render_template("one.html", user=user)

@app.route('/users/<url_id>/destroy')
def destroyOne(url_id):
    data = {
        "id": url_id
    }
    User.deleteOne(data)
    return redirect('/')

@app.route('/users/<url_id>/edit')
def editShow(url_id):
    data = {
        "id": url_id,
    }
    user = User.getOne(data)
    return render_template('update.html', user=user)

@app.route('/update_user/<url_id>', methods=["POST"])
def updateUser(url_id):
    data = {
        "id": url_id,
        "first_name": request.form["fname"],
        "last_name" : request.form["lname"],
        "email" : request.form["email"]
    }
    user = User.updateOne(data)
    return redirect(f"/users/{url_id}")