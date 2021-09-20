import React, { useState } from "react";
import axios from "axios";

const ProductForm = (props) => {
  const [title, setTitle] = useState("");
  const [price, setPrice] = useState("");
  const [description, setDescription] = useState("");

  const onSubmitHandler = (e) => {
    e.preventDefault();

    const newProduct = {
      title,
      price,
      description,
    };

    axios
      .post("http://localhost:8000/api/products/new", newProduct)
      .then((res) => {
        console.log("Response: ", res);
      })
      .catch((err) => {
        console.log("Error: ", err);
      });
  };

  return (
    <div>
      <form onSubmit={onSubmitHandler}>
        <label>Title</label>
        <input
          type="text"
          value={title}
          onChange={(e) => setTitle(e.target.value)}
        />
        <br />
        <label>Price</label>
        <input
          type="text"
          value={price}
          onChange={(e) => setPrice(e.target.value)}
        />
        <br />
        <label>Description</label>
        <input
          type="text"
          value={description}
          onChange={(e) => setDescription(e.target.value)}
        />
        <br />
        <button type="submit">Create</button>
      </form>
    </div>
  );
};
export default ProductForm;
