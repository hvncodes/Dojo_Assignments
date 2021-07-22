from flask import render_template,redirect,request
from flask_app import app
from flask_app.models.dojo import Dojo
from flask_app.models.ninja import Ninja

@app.route("/")
def index():
    return redirect('/dojos')

@app.route("/dojos")
def dojosPage():
    dojos = Dojo.get_all()
    # print(dojos)
    return render_template("dojos.html", all_dojos=dojos)

@app.route("/dojos/<url_id>")
def dojoPage(url_id):
    # print(url_id)
    data = {
        "id": url_id,
    }
    dojo = Dojo.get_dojo_with_ninjas(data)
    dojo_id = dojo.id
    dojo_name = dojo.name
    #get all ninjas in dojo ID
    ninjas = dojo.ninjas
    return render_template("dojo_show.html", all_ninjas=ninjas, dojo_id=dojo_id, dojo_name=dojo_name)

@app.route("/ninjas")
def ninjaPage():
    dojos = Dojo.get_all()
    return render_template("ninja_create.html", all_dojos=dojos)

@app.route('/create_ninja', methods=["POST"])
def create_ninja():
    data = {
        "dojo_id" : request.form["dojoSelect"],
        "first_name": request.form["fnameInput"],
        "last_name" : request.form["lnameInput"],
        "age" : request.form["ageInput"]
    }
    #{'dojo_id': '4', 'first_name': 'aaaaaaaaa', 'last_name': 'aaaaaaaaaa', 'age': '33'}
    # print(data)
    # 4
    # print(data["dojo_id"])
    # return redirect("/ninjas")
    Ninja.add_ninja(data)
    dojo_id = request.form["dojoSelect"] #or data['dojo_id']
    return redirect(f"/dojos/{dojo_id}")

@app.route('/create_dojo', methods=["POST"])
def create_dojo():
    data = {
        "name": request.form["nameInput"],
    }
    # print(request.form) #ImmutableMultiDict([('nameInput', 'aaaaaaa')])
    #{'dojo_id': '4', 'first_name': 'aaaaaaaaa', 'last_name': 'aaaaaaaaaa', 'age': '33'}
    # print(data)
    # 4
    # print(data["dojo_id"])
    # return redirect("/ninjas")

    Dojo.add_dojo(data)
    return redirect("/dojos")