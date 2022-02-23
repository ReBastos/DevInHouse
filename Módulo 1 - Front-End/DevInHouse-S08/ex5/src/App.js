import './App.css';
import profile from './images/profile.png';
import hamburguer from './images/hamburguer.jpg';
import shampoo from './images/shampoo.jpg'

import Contact from './components/contact';
import Post from './components/post';
import Product from './components/product';



function App() {
  return (
    <>
    <Contact 
    photo={profile} 
    name={'Exemplo'} 
    description={'Exemplo de descrição'}/>

    <Post profile={profile} 
    name={'Teste'} 
    description ={'5m'}
    image={hamburguer}
    text={'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed aliquam eros a arcu luctus, id semper elit porta. Cras tempor, tellus at fringilla semper, sapien felis placerat urna, sit amet cursus'}
    />

    <Product 
    productName={'Shampoo Granado'}
    productPic={shampoo}
    productPrice={'R$24,00'}
    />
    </>
  );
}

export default App;
