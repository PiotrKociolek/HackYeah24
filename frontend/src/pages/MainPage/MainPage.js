import { memo } from 'react';
import 'standard.css';
import './MainPage.css';
import React from 'react';
import ArticleThumbnail from './components/ArticleThumbnail/ArticleThumbnail';

function MainPage() {
  return (    
      <div className='main-page center flexBlock'>
        <div className='article-part flexBlock flexColumn'>
          <ArticleThumbnail/>
          <ArticleThumbnail/>
        </div>
        <div className='doctor-image'>
          <img alt="doctor"></img>
        </div>
        <a className='freepik-add' href="freepik.com">freepik.com</a>
      </div>
  );
}

export default memo(MainPage);
