import { memo } from 'react';
import '../../standard.css'
import './MainPage.css';
import React from 'react';
import ArticlePaper from '../MainPage/components/ArticlePaper/ArticlePaper';

function MainPage() {
  return (    
      <div className='main-page center flexBlock'>
        <div className='article-part flexBlock flexColumn'>
          <ArticlePaper/>
          <ArticlePaper/>
        </div>
        <div className='doctor-image'>
          <img alt="doctor image"></img>
        </div> 
      </div>
  );
}

export default memo(MainPage);
