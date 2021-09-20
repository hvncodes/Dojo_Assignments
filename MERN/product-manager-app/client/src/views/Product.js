import React, { useEffect, useState } from "react";
import { useHistory, useParams, Link } from "react-router-dom";
import axios from "axios";

const Product = (props) => {
  const [product, setProduct] = useState(null);
  const history = useHistory();
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

  const handleDelete = (productId) => {
    axios
      .delete("http://localhost:8000/api/products/delete/" + productId)
      .then((res) => {
        history.push("/products");
      })
      .catch((err) => {
        console.log("Error: ", err);
      });
  };

  if (product === null) {
    return "Loading...";
  }

  return (
    <div>
      <h2>{product.title}</h2>
      <p>Price: {product.price}</p>
      <p>Description: {product.description}</p>
      <Link to={"/products/" + product._id + "/edit"}>Edit</Link>
      {" | "}
      <button
        onClick={(e) => {
          handleDelete(product._id);
        }}
      >
        Delete
      </button>
    </div>
  );
};

export default Product;
