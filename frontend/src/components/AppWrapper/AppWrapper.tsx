import React, { ReactNode, useEffect, useState } from 'react';
import { memo } from 'react';
import Navbar from '../Navbar/Navbar';
import './AppWrapper.css';
import FormPage from '../FormPage/FormPage';

interface Props {
  children?: ReactNode
}

const AppWrapper = ({ children }: Props) => {
  const [isFormVisible, setIsFormVisible] = useState(true);

  return (
    <div className="App">
      <Navbar/>
      {isFormVisible && <FormPage setIsVisible={setIsFormVisible}/> }
      {children}
    </div>
  );
};

export default memo(AppWrapper);