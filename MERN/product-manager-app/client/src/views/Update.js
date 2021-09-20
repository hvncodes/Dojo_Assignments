import React, { useEffect, useState } from "react";
import axios from "axios";
import { useHistory, useParams } from "react-router-dom";

const Update = (props) => {
  const [title, setTitle] = useState("");
  const [price, setPrice] = useState("");
  const [description, setDescription] = useState("");
  const history = useHistory();
  const { id } = useParams();

  useEffect(() => {
    axios
      .get("http://localhost:8000/api/products/" + id)
      .then((res) => {
        setTitle(res.data.title);
        setPrice(res.data.price);
        setDescription(res.data.description);
      })
      .catch((err) => {
        console.log("Error: ", err);
      });
  }, [id]);

  const submitHandler = (e) => {
    e.preventDefault();
    axios
      .put("http://localhost:8000/api/products/update/" + id, {
        title,
        price: price,
        description,
      })
      .then((res) => {
        console.log("Response: ", res.data);
        history.push(`/products/${id}`);
      })
      .catch((err) => {
        console.log("Error: ", err);
      });
  };

  return (
    <div>
      <h1>Update Form</h1>
      <form onSubmit={submitHandler}>
        <p>
          <label>Title</label>
          <br />
          <input
            type="text"
            name="title"
            value={title}
            onChange={(e) => {
              setTitle(e.target.value);
            }}
          />
        </p>

        <p>
          <label>Price</label>
          <br />
          <input
            type="number"
            name="price"
            value={price}
            onChange={(e) => {
              setPrice(e.target.value);
            }}
          />
        </p>

        <p>
          <label>Description</label>
          <br />
          <input
            type="text"
            name="description"
            value={description}
            onChange={(e) => {
              setDescription(e.target.value);
            }}
          />
        </p>
        <input type="submit" />
      </form>
    </div>
  );
};

export default Update;
