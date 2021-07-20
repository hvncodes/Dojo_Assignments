from survey_app.config.mysqlconnection import connectToMySQL
from flask import flash

class Survey:
    def __init__( self , data ):
        self.id = data['id']
        self.name = data['name']
        self.location = data['location']
        self.language = data['language']
        self.comment = data['comment']
        self.created_at = data['created_at']
        self.updated_at = data['updated_at']

    @classmethod
    def save(cls, data):
        query = "INSERT INTO dojos (name, location, language, comment, created_at, updated_at ) VALUES (%(name)s, %(location)s, %(language)s, %(comment)s, NOW() , NOW() );"

        return connectToMySQL('dojo_survey_schema').query_db(query, data)

    @classmethod
    def get(cls, data):
        query = "SELECT * FROM dojos WHERE dojos.id = %(id)s;"
        result = connectToMySQL('dojo_survey_schema').query_db(query, data);
        return result[0]

    @staticmethod
    def validate_survey(survey):
        print(survey)
        is_valid = True
        # name required
        if len(survey['name']) == 0:
            flash("Name is required.","name")
            is_valid = False
        # location required
        if len(survey['location']) == 0:
            flash("Please select a Dojo location.","location")
            is_valid = False
        # language required
        if len(survey['language']) == 0:
            flash("Please select a Dojo language.","language")
            is_valid = False
        print(is_valid)
        return is_valid