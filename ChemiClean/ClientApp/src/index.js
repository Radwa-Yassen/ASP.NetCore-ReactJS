import 'bootstrap/dist/css/bootstrap.css';
import React from 'react';
import ReactDOM from 'react-dom';
import { Container } from 'reactstrap';
import { Products } from './components/Products';

import './custom.css'

const rootElement = document.getElementById('root');

ReactDOM.render(
    <div>
        <Container>
            <Products />
        </Container>
    </div>,
  rootElement);


