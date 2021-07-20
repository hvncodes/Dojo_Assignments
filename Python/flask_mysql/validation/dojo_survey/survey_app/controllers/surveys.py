from survey_app import app
from flask import render_template,redirect,request,session
from survey_app.models.survey import Survey

@app.route('/')
def index():
    return render_template('index.html')

@app.route('/process', methods=['POST'])
def processForm():
    data = {
        "name": request.form["inputName"],
        "location" : request.form["dojoLocation"],
        "language" : request.form["favLanguange"],
        "comment" : request.form["optionalComment"]
    }
    if not Survey.validate_survey(data):
        return redirect('/')
    # save ID of submitted survey, .save() method returns lastrowid (latest addition)
    session["last_submit_id"] = Survey.save(data)
    return redirect('/result')

@app.route('/result')
def result():
    if "last_submit_id" not in session:
        return redirect('/')
    data = {
        "id" : session["last_submit_id"]
    }
    one_survey = Survey.get(data)
    return render_template('result.html', survey=one_survey)

@app.errorhandler(404)
def page_not_found(e):
    return "404 Not Found"