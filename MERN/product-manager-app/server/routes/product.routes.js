const ProductController = require("../controllers/product.controller");

module.exports = (app) => {
  app.get("/api", ProductController.index);
  app.get("/api/products", ProductController.findAllProducts);
  app.get("/api/products/random", ProductController.findRandomProduct);
  app.get("/api/products/:id", ProductController.findOneProduct);
  app.post("/api/products/new", ProductController.createProduct);
  app.put("/api/products/update/:id", ProductController.updateProduct);
  app.delete("/api/products/delete/:id", ProductController.deleteProduct);
};
