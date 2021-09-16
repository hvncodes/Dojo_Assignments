const Student = require("../models/student.model");

module.exports.findAllStudents = (req, res) => {
  Student.find()
    .then(allDaStudents => res.json({ students: allDaStudents }))
    .catch(err => res.json({ message: "Something went wrong", error: err }));
};

module.exports.findOneSingleStudent = (req, res) => {
	Student.findOne({ _id: req.params.id })
		.then(oneSingleStudent => res.json({ student: oneSingleStudent }))
		.catch(err => res.json({ message: "Something went wrong", error: err }));
};

module.exports.createNewStudent = (req, res) => {
  Student.create(req.body)
    .then(newlyCreatedStudent => res.json({ student: newlyCreatedStudent }))
    .catch(err => res.json({ message: "Something went wrong", error: err }));
};

module.exports.updateExistingStudent = (req, res) => {
  Student.findOneAndUpdate({ _id: req.params.id }, req.body, { new: true })
    .then(updatedStudent => res.json({ student: updatedStudent }))
    .catch(err => res.json({ message: "Something went wrong", error: err }));
};

module.exports.deleteAnExistingStudent = (req, res) => {
  Student.deleteOne({ _id: req.params.id })
    .then(result => res.json({ result: result }))
    .catch(err => res.json({ message: "Something went wrong", error: err }));
};
