import React, { ReactNode, useState } from 'react';
import { memo } from 'react';
import Navbar from '../Navbar/Navbar';
import './AppWrapper.css';
import FormPage from '../FormPage/FormPage';

interface Props {
  children?: ReactNode
}

const AppWrapper = ({ children }: Props) => {
  const [isFormVisible, setIsFormVisible] = useState(false);

  return (
    <div className="App">
      <Navbar/>
      {isFormVisible && <FormPage setIsVisible={setIsFormVisible}/> }
      {children}
    </div>
  );
};

export default memo(AppWrapper);