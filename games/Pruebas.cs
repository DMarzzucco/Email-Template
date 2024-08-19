//backend
const express = require('express');
const cors = require('cors');
const app = express();
const port = 3001;

interface Message{
  id:number;
  text:string;
}

app.use(cors());
app.use(express.json());

let Messages: string [] = [];

app.get('/messages', (req, res) => {
  res.json(messages);
});

app.post('/messages', (req, res) => {
  const message.Message = req.body.message;
  messages.push(message);
  res.status(201).send('Message added');
});
-- //
app.post('/message', (req:Request, res:Respones) =>{
  const message:Message = req.body.message;
  try{
    if (typeof message === 'string'){
      Messages.push(message);
      res.status(201).send('Message Aded');
      console.log(message);
    } else{
      throw new Error ('invalid format')
    }
  }catch (error){
    res.status(400).send(error instanceof Error ? error.message: 'Uknown Error');
    return;
  }
})
app.delete('/message/:index', (req:Request, res:Respones) =>{
  const index:number = parseInt (req.params.index, 10);
  try{
    if(isNaN(index) || index <0 || indez >= Message.length){
      return res.status(401).send ('Message not Found');
    }
      Messages.splice(index, 1);
      console.log(delete)
      return res.status(200).send('Message was delete');

  }
})
-- 
app.listen(port, () => {
  console.log(`Server listening at http://localhost:${port}`);
});


//fetch api
// api.js

const getMessages = () => {
  return fetch('http://localhost:3001/messages')
    .then(response => {
      if (!response.ok) {
        throw new Error('Network response was not ok');
      }
      return response.json();
    });
};

const postMessage = (newMessage) => {
  return fetch('http://localhost:3001/messages', {
    method: 'POST',
    headers: {
      'Content-Type': 'application/json',
    },
    body: JSON.stringify({ message: newMessage }),
  })
  .then(response => {
    if (!response.ok) {
      throw new Error('Network response was not ok');
    }
    return response.text();
  });
};

export { getMessages, postMessage };

// front end
// App.js o el componente donde quieras usar las funciones

import React, { useState, useEffect } from 'react';
import { getMessages, postMessage } from './api'; // Asegúrate de que la ruta sea correcta

function App() {
  const [messages, setMessages] = useState([]);
  const [newMessage, setNewMessage] = useState('');

  useEffect(() => {
    getMessages()
      .then(data => setMessages(data))
      .catch(error => console.error('Error fetching messages:', error));
  }, []);

  const handleSubmit = (event) => {
    event.preventDefault();
    postMessage(newMessage)
      .then(() => {
        setMessages([...messages, newMessage]);
        setNewMessage('');
      })
      .catch(error => console.error('Error posting message:', error));
  };

  return (
  <div>
      <h1>Libro de Visitas</h1>
      <form onSubmit={handleSubmit}>
        <input
          type="text"
          value={newMessage}
          onChange={(e) => setNewMessage(e.target.value)}
        />
        <button type="submit">Enviar Mensaje</button>
      </form>
      <ul>
        {messages.map((message, index) => (
          <li key={index}>{message}</li>
        ))}
      </ul>
    </div>
  )
}
