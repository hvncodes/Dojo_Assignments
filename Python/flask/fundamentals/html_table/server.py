from flask import Flask, render_template, request, redirect, session
from random import randint
from datetime import datetime

app = Flask(__name__)

#Python\flask\fundamentals\html_table
@app.route('/')
def index():
    users = [
        {'first_name' : 'Michael', 'last_name' : 'Choi'},
        {'first_name' : 'John', 'last_name' : 'Supsupin'},
        {'first_name' : 'Mark', 'last_name' : 'Guillen'},
        {'first_name' : 'KB', 'last_name' : 'Tonel'}
    ]
    return render_template('index.html', users=users)

@app.errorhandler(404)
def page_not_found(e):
    return "404 Not Found"

if __name__=="__main__":
    app.run(debug=True)