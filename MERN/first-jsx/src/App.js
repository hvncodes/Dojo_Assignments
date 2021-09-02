import './App.css';
// import MyFirstComponent from './components/MyFirstComponent';
import PersonCard from './components/PersonCard';

var peopleArr =[
  {"firstName":"Jane", "lastName":"Doe", "age":45, "hairColor":"Black"},
  {"firstName":"John", "lastName":"Smith", "age":88, "hairColor":"Brown"},
  {"firstName":"Millard", "lastName":"Fillmore", "age":50, "hairColor":"Brown"},
  {"firstName":"Maria", "lastName":"Smith", "age":62, "hairColor":"Brown"}
]

function App() {
  return (
    <div className="App">
      {/* <MyFirstComponent/>
      <PersonCard firstName="Jane" lastName="Doe" age="45" hairColor="Black"/>
      <PersonCard firstName="John" lastName="Smith" age="88" hairColor="Brown"/>
      <PersonCard firstName="Millard" lastName="Fillmore" age="50" hairColor="Brown"/>
      <PersonCard firstName="Maria" lastName="Smith" age="62" hairColor="Brown"/> */}
      {
        peopleArr.map(person => {
          return <PersonCard firstName={person.firstName} lastName={person.lastName} age={person.age} hairColor={person.hairColor} />
        })
      }
    </div>
  );
}

export default App;
