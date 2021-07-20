from email_app.config.mysqlconnection import connectToMySQL
from flask import flash
import re
EMAIL_REGEX = re.compile(r'^[a-zA-Z0-9.+_-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]+$') 

class Email:
    def __init__(self, data):
        self.id = data['id']
        self.email = data['email']
        self.created_at = data['created_at']
        self.updated_at = data['updated_at']

    @classmethod
    def get_all(cls):
        query = "SELECT * FROM emails;"
        results = connectToMySQL('email_schema').query_db(query)
        emails = []
        for email in results:
            emails.append( cls(email) )
        return emails

    @classmethod
    def save(cls, data):
        query = "INSERT INTO emails (email, created_at, updated_at ) VALUES (%(email)s, NOW() , NOW() );"

        return connectToMySQL('email_schema').query_db(query, data)

    @classmethod
    def get(cls, data):
        query = "SELECT * FROM emails WHERE emails.id = %(id)s;"
        result = connectToMySQL('email_schema').query_db(query, data);
        return result[0]

    @staticmethod
    def validate_email(data):
        #print(data) -> {'email': 'email@example.com'}
        is_valid = True
        # email required
        if len(data['email']) == 0:
            flash("Email is required.","email")
            is_valid = False
        # email required to match regex
        if not EMAIL_REGEX.match(data['email']): 
            flash("Email should match this format: email@example.com","email")
            is_valid = False
        else:
            flash(f"The email address you entered {data['email']} is a VALID email address! Thank you!","email")
        return is_valid