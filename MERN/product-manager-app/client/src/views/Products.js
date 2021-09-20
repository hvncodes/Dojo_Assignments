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

  return (
    <div>
      <h3>All Products: </h3>
      {products.map((product, index) => {
        return (
          <div key={index}>
            <Link to={`/products/${product._id}`}>
              <h4>{product.title}</h4>
            </Link>
          </div>
        );
      })}
    </div>
  );
};
export default Products;
