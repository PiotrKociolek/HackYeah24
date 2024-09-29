import React from 'react';
import ReactDOM from 'react-dom/client';
import { BrowserRouter, Routes, Route } from "react-router-dom";
import './index.css';
import reportWebVitals from './reportWebVitals';
import MainPage from './pages/MainPage/MainPage';
import LoginPage from './pages/LoginPage/LoginPage';
import PrivateRoute from './components/PrivateRoute/PrivateRoute';
import AppWrapper from './components/AppWrapper/AppWrapper.tsx';
import ArticlePage from './pages/ArticlePage/ArticlePage.tsx';
import ExpertPage from './pages/ExpertPage/ExpertPage.tsx';

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <React.StrictMode>
    <BrowserRouter>
      <AppWrapper>
        <Routes>
          <Route path="/" element={<PrivateRoute />}>
            <Route index element={<MainPage />} />
          </Route>
          <Route path="login" element={<LoginPage />} />
          <Route path="articles" element={<ArticlePage/>} />
          <Route path="experts" element={<ExpertPage/>} />
          <Route path="*" element={<div>404</div>} />
        </Routes>
      </AppWrapper>
    </BrowserRouter>
  </React.StrictMode>
);

reportWebVitals();
