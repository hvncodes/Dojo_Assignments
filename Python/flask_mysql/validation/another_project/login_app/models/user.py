from login_app.config.mysqlconnection import connectToMySQL
from flask import flash
from flask_bcrypt import Bcrypt
from login_app import app
import re

bcrypt = Bcrypt(app)
LETTERS_ONLY_REGEX = re.compile(r'^[a-zA-Z]+$')
EMAIL_REGEX = re.compile(r'^[a-zA-Z0-9.+_-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]+$')

class User:
    def __init__(self, data):
        self.id = data['id']
        self.first_name = data['first_name']
        self.last_name = data['last_name']
        self.email = data['email']
        self.password = data['password']
        self.created_at = data['created_at']
        self.updated_at = data['updated_at']

    @classmethod
    def save(cls, data):
        query = "INSERT INTO users (first_name, last_name, email, password, created_at, updated_at) VALUES (%(first_name)s, %(last_name)s, %(email)s, %(password)s, NOW(), NOW());"

        return connectToMySQL('login_schema').query_db(query, data)

    @classmethod
    def is_email_unique(cls, data):
        query = "SELECT * FROM users WHERE email = %(emailInput)s;"

        results = connectToMySQL('login_schema').query_db(query, data)
        # length of 0 means the db doesn't have that email,
        # meaning a return of True IS unique
        # return of False means it already exists
        return len(results) == 0

    @classmethod
    def get_user_by_id(cls, data):
        query = "SELECT * FROM users WHERE id = %(id)s;"
        results = connectToMySQL('login_schema').query_db(query, data)

        if len(results[0]) > 0:
            return cls(results[0])
        else:
            return False

    @classmethod
    def get_user_by_email(cls, data):
        query = "SELECT * FROM users WHERE email = %(emailInput)s;"
        results = connectToMySQL('login_schema').query_db(query, data)

        if len(results) == 0:
            return False
        else:
            return cls(results[0])

    @staticmethod
    def validate_registration(user):
        is_valid = True

        #first name, not empty
        if len(user["fnameInput"]) == 0:
            flash("First name is required.", "first_name")
            is_valid = False
        #at least 2 characters
        elif len(user["fnameInput"]) < 2:
            flash("First name must be at least 2 characters in length.", "first_name")
            is_valid = False
        #letters only
        elif not LETTERS_ONLY_REGEX.match(user["fnameInput"]):
            flash("First name must not contain non-alphabetic characters.", "first_name")
            is_valid = False

        #last name
        #not empty/submission required
        if len(user["lnameInput"]) == 0:
            flash("Last name is required.", "last_name")
            is_valid = False
        #at least 2 characters
        elif len(user["lnameInput"]) < 2:
            flash("Last name must be at least 2 characters in length.", "last_name")
            is_valid = False
        #letters only
        elif not LETTERS_ONLY_REGEX.match(user["lnameInput"]):
            flash("Last name must not contain non-alphabetic characters.", "last_name")
            is_valid = False

        #mail
        #submission required
        if len(user["emailInput"]) == 0:
            flash("Email is required.", "email")
            is_valid = False
        #valid format
        elif not EMAIL_REGEX.match(user["emailInput"]):
            flash("Invalid email format. Must meet user@example.com format", "email")
            is_valid = False
        #unique in db
        elif not User.is_email_unique(user):
            flash("A user with that email already exists.", "email")
            is_valid = False

        #password
        #submission required
        if len(user["passwordInput"]) == 0:
            flash("Password is required.", "password")
            is_valid = False
        elif len(user["passwordInput"]) < 8:
            flash("Password must be at least 8 characters in length.", "password")
            is_valid = False
        #matches confirm password
        elif user["passwordInput"] != user["confirmInput"]:
            flash("Passwords must match.", "confirm")
            is_valid = False

        return is_valid

    @staticmethod
    def validate_login(user):
        print(user)
        user_in_db = User.get_user_by_email(user)
        #Does a user in our db have that email
        if not user_in_db:
            flash("Invalid email/password","login")
            return False

        if not bcrypt.check_password_hash(user_in_db.password, user["passwordInput"]):
            flash("Invalid email/password","login")
            return False

        return user_in_db.id