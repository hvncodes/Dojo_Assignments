const express = require("express");
const cors = require("cors");

// Environment vars.
const port = 8000;
const db_name = "product_db";

// Immediately execute the import mongoose.config.js function.
require("./config/mongoose.config")(db_name);

const app = express();

// req.body undefined without this!
app.use(express.json());
app.use(cors());

require("./routes/product.routes")(app);

app.listen(port, () =>
  console.log(`The server is all fired up on port ${port}.`)
);
