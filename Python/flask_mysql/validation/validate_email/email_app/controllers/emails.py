from flask import render_template,redirect,request,session
from email_app import app
from email_app.models.email import Email
#/ display form
@app.route('/')
def index():
    return render_template('index.html')

#/process 
@app.route('/process', methods=['POST'])
def processEmail():
    data = {
        'email' : request.form['emailInput']
    }
    if not Email.validate_email(data):
        # we redirect to the template with the form.
        return redirect('/')
    # save
    Email.save(data)
    return redirect('/success')

#/success
@app.route('/success')
def successPage():
    emails = Email.get_all()
    return render_template('success.html', emails=emails)