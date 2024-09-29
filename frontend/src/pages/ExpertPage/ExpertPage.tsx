import { memo } from 'react';
import './ExpertPage.css';
import 'standard.css';
import React from 'react';

function ExpertPage() {
  return (
    <div className="experts center flexBlock flexWrap">
      <a href="#" className='expert flexBlock flexLeft shadow'>
        <img alt="expert-image" />
        <div className='content flexBlock flexColumn'>
          <h3> Jan Sobieski </h3>
          <h2> (+48) 123456789 </h2>
          <p className='date'> Król Polski </p>
        </div>
      </a>
      <a href="#" className='expert flexBlock flexLeft shadow'>
        <img alt="expert-image" />
        <div className='content flexBlock flexColumn'>
          <h3> Zygmunt August </h3>
          <h2> (+48) 123456789 </h2>
          <p className='date'> Król Polski </p>
        </div>
      </a>
      <a href="#" className='expert flexBlock flexLeft shadow'>
        <img alt="expert-image" />
        <div className='content flexBlock flexColumn'>
          <h3> Kazimierz Wielki </h3>
          <h2> (+48) 123456789 </h2>
          <p className='date'> Król Polski </p>
        </div>
      </a>
      <a href="#" className='expert flexBlock flexLeft shadow'>
        <img alt="expert-image" />
        <div className='content flexBlock flexColumn'>
          <h3> Piotr Szczepaniak </h3>
          <h2> (+48) 123456789 </h2>
          <p className='date'> Fizjoterapeuta </p>
        </div>
      </a>
      <a href="#" className='expert flexBlock flexLeft shadow'>
        <img alt="expert-image" />
        <div className='content flexBlock flexColumn'>
          <h3> Władysław Łokietek </h3>
          <h2> (+48) 123456789 </h2>
          <p className='date'> Król Polski </p>
        </div>
      </a>
      <a href="#" className='expert flexBlock flexLeft shadow'>
        <img alt="expert-image" />
        <div className='content flexBlock flexColumn'>
          <h3> Bolesław Chrobry </h3>
          <h2> (+48) 123456789 </h2>
          <p className='date'> Król Polski </p>
        </div>
      </a>
    </div>
  );
}

export default memo(ExpertPage);
