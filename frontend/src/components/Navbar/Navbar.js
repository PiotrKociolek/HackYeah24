import { memo } from 'react';
import logo from './logo.svg';
import './Navbar.css';
import 'standard.css';
import React from 'react';

function Navbar() {
  return (    
      <header className="header flexBlock">
        <div className="logo flexBlock flexLeft">
          <a href="/" className="logo-icon">
            <img src={logo} alt="logo" />
          </a>
          <a className="home-link"> 
            <h1 className='h1'> Fit Life </h1>
          </a>
        </div>
        
        <div className='login flexBlock flexRight'>
          <a href="/login" className="button styled"> Zaloguj się </a>
          <a href="#" className='button unstyled'> Zarejestruj się </a>
        </div>
      </header>
  );
}

export default memo(Navbar);
