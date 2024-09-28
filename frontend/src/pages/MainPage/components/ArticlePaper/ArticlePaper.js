import { memo } from 'react';
import './ArticlePaper.css';
import 'standard.css';
import React from 'react';

function ArticlePaper() {
  return (    
    <a href="#" className='article shadow'>
      <img alt="article-image" />
      <div className='content flexBlock flexColumn flexLeft'>
        <h3> Imię i nazwisko </h3>
        <h2> Lorem ipsum dolor sit amet, consectetur adipiscing elit </h2>
        <date> Wrzesień 28, 2024</date>
      </div>
    </a>
  );
}

export default memo(ArticlePaper);
