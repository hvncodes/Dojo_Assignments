const mongoose = require("mongoose");

const StudentSchema = new mongoose.Schema(
  {
    name: {
      type: String,
      required: [true, "{PATH} is required."],
      minlength: [2, "{PATH} must be at least {MINLENGTH} characters."],
    },

    home_state: {
      type: String,
      required: [true, "{PATH} is required."],
      minlength: [2, "{PATH} must be at least {MINLENGTH} characters."],
    },

    birthday: {
      month: {
        type: String,
        required: [true, "{PATH} is required."],
      },
      day: {
        type: Number,
        required: [true, "{PATH} is required."],
      },
      year: {
        type: Number,
        required: [true, "{PATH} is required."],
      },
    },

    interests: {
      type: [String],
      required: [true, "{PATH} is required."],
    },

    number_of_belts: {
      type: Number,
      required: [true, "{PATH} is required."],
    },

    // updated_on: {
    //   type: Date,
    //   default: Date.now,
    // },
  },
  { timestamps: true }
);

const Student = mongoose.model("Student", StudentSchema);

module.exports = Student;
