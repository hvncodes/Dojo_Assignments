const Student = require("../models/student.model");

module.exports.findAllStudents = (req, res) => {
  Student.find()
    .then((allDaStudents) => res.json(allDaStudents))
    .catch((err) => res.json({ message: "Something went wrong", error: err }));
};

module.exports.findOneSingleStudent = (req, res) => {
  Student.findOne({ _id: req.params.id })
    .then((oneSingleStudent) => res.json(oneSingleStudent))
    .catch((err) => res.json({ message: "Something went wrong", error: err }));
};

module.exports.createNewStudent = (req, res) => {
  Student.create(req.body)
    .then((newlyCreatedStudent) => res.json(newlyCreatedStudent))
    .catch((err) => res.json({ message: "Something went wrong", error: err }));
};

module.exports.updateExistingStudent = (req, res) => {
  Student.findOneAndUpdate({ _id: req.params.id }, req.body, { new: true })
    .then((updatedStudent) => res.json(updatedStudent))
    .catch((err) => res.json({ message: "Something went wrong", error: err }));
};

module.exports.deleteAnExistingStudent = (req, res) => {
  Student.deleteOne({ _id: req.params.id })
    .then((result) => res.json(result))
    .catch((err) => res.json({ message: "Something went wrong", error: err }));
};
