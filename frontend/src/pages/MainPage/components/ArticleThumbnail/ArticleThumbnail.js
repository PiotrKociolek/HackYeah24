import { memo } from 'react';
import './ArticleThumbnail.css';
import 'standard.css';
import React from 'react';

function ArticleThumbnail() {
  return (    
    <a href="#" className='article shadow'>
      <img alt="article-image" />
      <div className='content flexBlock flexColumn flexTop'>
        <h3> Imię i nazwisko </h3>
        <h2> Lorem ipsum dolor sit amet, consectetur adipiscing elit </h2>
        <p className='date'> Wrzesień 28, 2024 </p>
      </div>
    </a>
  );
}

export default memo(ArticleThumbnail);
