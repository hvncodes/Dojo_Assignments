import './App.css';
import React, { useState, useEffect } from 'react';

function App() {
  const [newToDo, setNewTodo] = useState("");
  const [toDoError, setToDoError] = useState("");
  const [toDoList, setToDoList] = useState(() => {
    // getting stored value
    const saved = localStorage.getItem("toDoList");
    const initialValue = JSON.parse(saved);
    return initialValue || [];
  });

  useEffect(() => {
    // storing input toDoList
    localStorage.setItem("toDoList", JSON.stringify(toDoList));
  }, [toDoList]);
  const submitNewTodo = (e) => {
    e.preventDefault();
    if(newToDo.length < 1) {
      return;
    }
    const toDoItem = {
      text: newToDo,
      isComplete: false
    }
    setToDoList([...toDoList, toDoItem]);
    setNewTodo("");
  }

  const handleToDo = (e) => {
    if(e.target.value.length < 1) {
      setToDoError("To Do is required!");
    }
    console.log(newToDo);
    setNewTodo(e.target.value);
  }

  const deleteToDo = (delIdx) => {
    let filteredList = toDoList.filter((item, i) => {
      return i !== delIdx;
    });
    setToDoList(filteredList);
  }

  const checkboxToDo = (idx) => {
    const updatedToDoList = toDoList.map(
      (item, i) => {
        if (i === idx) {
          let updatedItem = {...item, isComplete: !item.isComplete}
          return updatedItem;
        }
        return item;
      }
    );
    setToDoList(updatedToDoList);
  }
  
  return (
    <div className="App">
      <form onSubmit={ submitNewTodo }>
        <input
          type="text"
          value={ newToDo }
          onChange={ handleToDo }
        />
        {
          toDoError ?
          <p style={{color:'red'}}>{ toDoError }</p> :
          ''
        }
        <div>
          <button>Add</button>
        </div>
      </form>
      {
        toDoList.map((item, i) => {
          let spanClasses = [];
          if (item.isComplete) {
            spanClasses.push("line-through");
          }
          return (
            <div key={i}>
              <span className={ spanClasses.join(" ") }>{item.text}</span>
              <input
                type="checkbox"
                checked={item.isComplete}
                onChange={(e) => {
                  checkboxToDo(i)
                }}
              />
              <button 
                onClick={(e) => deleteToDo(i)}
                style={{marginLeft: "20px"}}
              >
                Delete
              </button>
            </div>
          );
        })
      }
    </div>
  );
}

export default App;
