from flask import Flask, render_template, request, redirect, session

app = Flask(__name__)
app.secret_key = "SECRET KEY GOES HERE"
#Python\flask\fundamentals\dojo_survey
@app.route('/')
def index():
    return render_template('index.html')

@app.route('/process', methods=['POST'])
def processForm():
    session["name"] = request.form["inputName"]
    session["location"] = request.form["dojoLocation"]
    session["language"] = request.form["favLanguange"]
    session["comment"] = request.form["optionalComment"]
    return redirect('/result')

@app.route('/result')
def result():
    return render_template('result.html')

@app.errorhandler(404)
def page_not_found(e):
    return "404 Not Found"

if __name__=="__main__":
    app.run(debug=True)