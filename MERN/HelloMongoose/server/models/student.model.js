const mongoose = require("mongoose");

const StudentSchema = new mongoose.Schema({
	name: String,
	home_state: String,
	birthday: {
		month: String,
		day: Number,
		year: Number
	},
	interests: [String],
	number_of_belts: Number,
	updated_on: {
		type: Date,
		default: Date.now
	}
});

const Student = mongoose.model("Student", StudentSchema);

module.exports = Student;