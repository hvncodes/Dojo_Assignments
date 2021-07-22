# pipenv install flask pymysql flask-bcrypt
from login_app import app
from login_app.controllers import users

if __name__=="__main__":
    app.run(debug=True)