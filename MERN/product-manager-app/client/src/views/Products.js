import React, { useEffect, useState } from "react";
import axios from "axios";
import { Link } from "react-router-dom";
const Products = (props) => {
  const [products, setProducts] = useState([]);

  useEffect(() => {
    axios
      .get("http://localhost:8000/api/products")
      .then((res) => {
        setProducts(res.data);
      })
      .catch((err) => {
        console.log("Error: ", err);
      });
  }, []);

  const handleDelete = (productId) => {
    axios
      .delete("http://localhost:8000/api/products/delete/" + productId)
      .then((res) => {
        const filtered = products.filter((product) => {
          return product._id !== productId;
        });
        setProducts(filtered);
      })
      .catch((err) => {
        console.log(err.response);
      });
  };

  return (
    <div>
      <h3>All Products: </h3>
      {products.map((product, index) => {
        return (
          <div key={index}>
            <Link to={`/products/${product._id}`}>
              <h4>{product.title}</h4>
            </Link>
            <button
              onClick={(e) => {
                handleDelete(product._id);
              }}
            >
              Delete
            </button>
          </div>
        );
      })}
    </div>
  );
};
export default Products;
