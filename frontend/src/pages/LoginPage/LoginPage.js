import { memo } from 'react';
import './LoginPage.css';
import 'standard.css';
import React from 'react';

function LoginPage() {
  return (    
    <div className='login-page center flexBlock flexColumn'>
      <h2 className='h2'>Zaloguj się</h2>
      <form className='form flexBlock flexColumn'>
        <div className='input-box'>
          <label className='flexBlock flexFull'>Login</label>
          <input type='text' placeholder='Login'/>
        </div>
        <div className='input-box'>
          <label className='flexBlock flexFull'>Hasło</label>
          <input type='password' placeholder='Hasło'/>
        </div>
        <a href="#" className='button styled'>Zaloguj</a>
      </form>
    </div>
  );
}

export default memo(LoginPage);
