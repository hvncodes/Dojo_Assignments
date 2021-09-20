import React, { useEffect, useState } from "react";
import { useParams } from "react-router-dom";
import axios from "axios";

const Product = (props) => {
  const [product, setProduct] = useState(null);
  const { id } = useParams();

  useEffect(() => {
    axios
      .get("http://localhost:8000/api/products/" + id)
      .then((res) => {
        setProduct(res.data);
      })
      .catch((err) => {
        console.log("Error: ", err);
      });
  }, [id]);

  if (product === null) {
    return "Loading...";
  }

  return (
    <div>
      <h2>{product.title}</h2>
      <p>Price: {product.price}</p>
      <p>Description: {product.description}</p>
    </div>
  );
};

export default Product;
