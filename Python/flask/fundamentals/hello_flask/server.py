from flask import Flask, render_template  # Import Flask to allow us to create our app
app = Flask(__name__)    # Create a new instance of the Flask class called "app"
@app.route('/')          # The "@" decorator associates this route with the function immediately following
def hello_world():
    return 'Hello World!'  # Return the string 'Hello World!' as a response

@app.route('/success')
def success():
    return "success"

@app.route('/hello/<name>') # for a route '/hello/____' anything after '/hello/' gets passed as a variable 'name'
def hello(name):
    print(name)
    return "Hello, " + name

@app.route('/users/<username>/<id>') # for a route '/users/____/____', two parameters in the url get passed as username and id
def show_user_profile(username, id):
    print(username)
    print(id)
    return "username: " + username + ", id: " + id

@app.route('/dojo')
def show_dojo():
    return "Dojo!";

@app.route('/say/<word>')
def say_word(word):
    return "Welcome to the route: /" + word + "<br>" + "Hi " + word.capitalize() + "!";

@app.route('/repeat/<num>/<word>')
def repeatWord(num, word):
    rtnStr = ""
    for x in range(int(num)):
        rtnStr += word
        if (x < int(num)-1):
            rtnStr += "<br>"
    return rtnStr
@app.errorhandler(404)
def page_not_found(e):
    return "404 Not Found<br>Sorry! No response. Try again."
if __name__=="__main__":   # Ensure this file is being run directly and not from a different module    
    app.run(debug=True)    # Run the app in debug mode.

