from flask_app.config.mysqlconnection import connectToMySQL
from flask_app.models.ninja import Ninja
from flask_app.models import ninja

class Dojo:
    def __init__( self , data ):
        self.id = data['id']
        self.name = data['name']
        self.created_at = data['created_at']
        self.updated_at = data['updated_at']
        self.ninjas = []

    @classmethod
    def get_all(cls):
        query = "SELECT * FROM dojos;"
        results = connectToMySQL('dojos_and_ninjas').query_db(query)
        dojos = []
        for dojo in results:
            dojos.append( cls(dojo) )
        return dojos

    @classmethod
    def get(cls, data):
        query = "SELECT * FROM dojos WHERE dojos.id = %(id)s;"
        results = connectToMySQL('dojos_and_ninjas').query_db(query,data)
        print(results[0])
        dojo = cls( results[0] )
        return dojo

    @classmethod
    def add_dojo( cls , data ):
        query = "INSERT INTO dojos ( name , created_at , updated_at ) VALUES (%(name)s,NOW(),NOW());"
        return connectToMySQL('dojos_and_ninjas').query_db(query,data)
    
    @classmethod
    def get_dojo_with_ninjas( cls , data ):
        query = "SELECT * FROM dojos LEFT JOIN ninjas ON ninjas.dojo_id = dojos.id WHERE dojos.id = %(id)s;"
        results = connectToMySQL('dojos_and_ninjas').query_db( query , data )
        # groups will be a list of music group objects from our raw data
        dojo = cls( results[0] )
        for row_from_db in results:
            # parse the ninja data to make instances of ninjas and add them into our list.
            # print(row_from_db)
            # {'id': 4,
            # 'name': 'Seattle',
            # 'created_at': datetime.datetime(2021, 7, 15, 0, 18, 52),
            # 'updated_at': datetime.datetime(2021, 7, 15, 0, 18, 52),
            # 'ninjas.id': 4,
            # 'dojo_id': 4,
            # 'first_name': 'Adam',
            # 'last_name': 'Lang',
            # 'age': 20,
            # 'ninjas.created_at': datetime.datetime(2021, 7, 15, 0, 27, 41),
            # 'ninjas.updated_at': datetime.datetime(2021, 7, 15, 0, 27, 41)}
            ninja_data = {
                "id" : row_from_db["ninjas.id"],
                "dojo_id" : row_from_db["dojo_id"],
                "first_name" : row_from_db["first_name"],
                "last_name" : row_from_db["last_name"],
                "age" : row_from_db["age"],
                "created_at" : row_from_db["ninjas.created_at"],
                "updated_at" : row_from_db["ninjas.updated_at"]
            }
            dojo.ninjas.append( ninja.Ninja( ninja_data ) )
        return dojo