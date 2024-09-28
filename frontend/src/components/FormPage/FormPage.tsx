import { memo } from 'react';
import './FormPage.css';
import 'standard.css';
import React from 'react';

interface Props {
  setIsVisible: React.Dispatch<React.SetStateAction<boolean>>;
}

function FormPage({setIsVisible}: Props) {
  return (    
    <div className='form-box flexBlock shadow'>
     
    </div>
  );
}

export default memo(FormPage);
