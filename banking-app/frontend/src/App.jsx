import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'

import {Routes,Route, Link} from 'react-router-dom';

function HOME(){
  return(
    <div>
      <h1>Banking App</h1>
      <Nav/>
    </div>
  );
}

function Acc(){
  return(
    <div>
      <h1>Accounts</h1>
      <Nav/>
    </div>
  )
}

function Nav(){
  return(
    <div>
      <Link to={"/Home"}><button>Home</button></Link>
      <Link to={"/Acc"}><button>Accounts</button></Link>
    </div>
  )
}

function App() {
  return (
    <div>
     <Routes>
      <Route path='/Home' element={<HOME/>}/>
      <Route path='/Acc' element={<Acc/>}/>
     </Routes>
    </div>
  );
}

export default App
