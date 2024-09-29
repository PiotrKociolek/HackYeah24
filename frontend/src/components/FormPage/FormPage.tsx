import { memo } from 'react';
import './FormPage.css';
import 'standard.css';
import React from 'react';
import RadioAnswer from './components/RadioAnswer';

interface Props {
  setIsVisible: React.Dispatch<React.SetStateAction<boolean>>;
}

function FormPage({setIsVisible}: Props) {
  const answers = ['Bardzo dobrze', 'Dobrze', 'Źle', 'Beznadziejnie'];

  return (    
    <div className='form-box flexBlock flexColumn flexLeft flexTop shadow'>
      <a className="exit-icon flexBlock flexRight" onClick={() => setIsVisible(false)}>x</a>
      <p className="question flexBlock flexLeft">Jak określiłbyś swoje samopoczucie ostatnimi dniami</p>
      
      <div className="answers flexBlock flexColumn flexTop">
        {answers.map((answer, index) => 
          <RadioAnswer key={index} answer={answer} id={`answer-${index}`}/>
        )}
      </div>

      <div className='button-box flexBlock flexRight'>
        <a className="button styled outlined">Dalej</a>
      </div>
      
    </div>
  );
}

export default memo(FormPage);
