from flask import Flask, render_template, redirect, request, session
from user import User
app = Flask(__name__)

@app.route("/")
def index():
    users = User.get_all()
    #print(users)
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
    User.save(data)
    return redirect('/')
if __name__ == "__main__":
    app.run(debug=True)