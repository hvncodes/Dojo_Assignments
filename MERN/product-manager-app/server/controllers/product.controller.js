const Product = require("../models/product.model");

module.exports = {
  index(req, res) {
    res.json({
      message: "Hello World",
    });
  },

  findAllProducts(req, res) {
    Product.find()
      .then((allProducts) => res.json(allProducts))
      .catch((err) => res.status(400).json(err));
  },

  findOneProduct(req, res) {
    Product.findById(req.params.id)
      .then((oneProduct) => res.json(oneProduct))
      .catch((err) => res.status(400).json(err));
  },

  createProduct(req, res) {
    Product.create(req.body)
      .then((newProduct) => res.json(newProduct))
      .catch((err) => res.status(400).json(err));
  },

  updateProduct(req, res) {
    Product.findByIdAndUpdate(req.params.id, req.body, {
      runValidators: true, // Run model validations again.
      new: true, // return newly updated document.
    })
      .then((updatedProduct) => res.json(updatedProduct))
      .catch((err) => res.status(400).json(err));
  },

  deleteProduct(req, res) {
    Product.findByIdAndDelete(req.params.id)
      .then((result) => res.json(result))
      .catch((err) => res.status(400).json(err));
  },
};

module.exports.findRandomProduct = (req, res) => {
  Product.countDocuments((err, count) => {
    console.log("There are %d products in the db.", count);
    let random = Math.floor(Math.random() * count);
    Product.findOne()
      .skip(random)
      .exec((err, result) => {
        res.json(result);
      });
  });
};
