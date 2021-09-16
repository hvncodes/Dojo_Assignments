const StudentController = require("../controllers/student.controller");

module.exports = app => {
  app.get("/api/students/", StudentController.findAllStudents);
  app.get("/api/students/:id", StudentController.findOneSingleStudent);
  app.put("/api/students/update/:id", StudentController.updateExistingStudent);
  app.post("/api/students/new", StudentController.createNewStudent);
  app.delete("/api/students/delete/:id", StudentController.deleteAnExistingStudent);
};