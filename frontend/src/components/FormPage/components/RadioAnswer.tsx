import { memo } from 'react';
import './RadioAnswer.css';
import 'standard.css';
import React from 'react';

interface Props {
  answer: string;
  id: string;
}

function RadioAnswer({answer, id}: Props) {
  return (    
    <div className="answer flexBlock">
      <input type="radio" id={id} name="answer" value={answer}/>
      <label htmlFor={id}>{answer}</label>
    </div>
  );
}

export default memo(RadioAnswer);
