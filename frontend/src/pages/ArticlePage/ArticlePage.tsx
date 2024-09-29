import { memo } from 'react';
import './ArticlePage.css';
import 'standard.css';
import React from 'react';

function ArticlePage() {
  return (    
    <div className='article-body center flexBlock flexColumn flexTop'>
      <img alt="article-image" />
      <div className='content flexBlock flexColumn flexTop'>
        <h3> Imię i nazwisko </h3>
        <h2> Lorem ipsum dolor sit amet, consectetur adipiscing elit </h2>
        <p className='date'> Wrzesień 28, 2024</p>
      </div>
    </div>
  );
}

export default memo(ArticlePage);
