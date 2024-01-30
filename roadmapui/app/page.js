"use client"
import NavBar from "@/components/NavBar";
import React, { Fragment, useState, useEffect } from "react";
import roadmap from '@/public/assets/be5d0f1a026f48a2fd5a5b9cc6718234-removebg-preview.jpg';
import Image from "next/image";
import Head from "next/head";
import MySlider from "@/components/MySlider";
import Connexion from "@/components/Connexion";
import "../styles/styleHome.css";
import UserService from "@/services/UserService";
import Service from "@/services";
import MYFooter from "@/components/MYFooter";

export default function Home() {
  const [showModal, setShowModal] = useState(false);
  const [showModal2, setShowModal2] = useState(false);

  const [fullname, setFullname] = useState('');
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');
  const [phoneNumber, setPhoneNumber] = useState('');
  const [conPassword, setConPassword] = useState('');

  const handleSignUpSubmit = async (e) => {
    e.preventDefault();

    try {
        const formData = {
            fullname,
            email,
            password,
            phoneNumber,
            conPassword,
           
        };
        const response = await UserService.create(formData);

        console.log("Utilisateur enregistré avec succès :", response);
        setFullname("");
        setEmail("");
        setPassword("");
        setPhoneNumber("");
        setConPassword("");
       
    } catch (error) {
        console.error("Erreur lors de l'enregistrement de l'utilisateur :", error);
    }
};
  const handleLoginSubmit = async (e) => {
    e.preventDefault();

    try {
      
      const response = await Service.login(email, password);
      console.log('Login response:', response);
      setShowModal(false);
    } catch (error) {
      console.error('Error during login:', error);
    }
  };

  return (
    <Fragment>
    <html lang='en'>
      <Head>

      <link rel="stylesheet" type="text/css" charset="UTF-8" href="https://cdnjs.cloudflare.com/ajax/libs/slick-carousel/1.6.0/slick.min.css" /> 
<link rel="stylesheet" type="text/css" href="https://cdnjs.cloudflare.com/ajax/libs/slick-carousel/1.6.0/slick-theme.min.css" />
      </Head>
    <body >
    <>
    <NavBar setShowModal={setShowModal} setShowModal2={setShowModal2} />
    </>
    <div className="flex flex-col md:flex-row items-center justify-center px-10 mx-auto max-w-7xl">
  <div className="md:mr-4 md:w-1/2">
    <h1 className="text-4xl md:text-6xl font-bold text-purple-600 mb-4">Roadmap Website</h1>
    <p className="text-white paragraphe">
     
        Le site "Roadmap Website" offre une sélection diversifiée de roadmaps parmi lesquels vous pouvez 
        choisir en fonction de vos besoins spécifiques. Chaque roadmap propose une série d'actions à entreprendre.
        À l'intérieur de chaque action, vous découvrirez une liste de tâches spécifiques à accomplir. Le processus
        global vise à vous guider de manière structurée et progressive dans l'accomplissement de vos objectifs, 
        en décomposant le parcours en actions claires et mesurables, puis en détaillant ces actions en tâches
        spécifiques pour une approche plus gérable.
    </p>
  </div>
  <div className="md:w-1/2 road"  >
    <Image
       src={roadmap}
       alt=""
       width={400}
       height={300}
    />
  </div>
</div>
    <>
    <MySlider/>
    </>
 
    <>
    <Connexion isVisible={showModal} onClose ={() =>setShowModal(false)}> 
      <div className="py-6 px-6 lg:px-8 text-left">
      <h3  className="text-xl  mb-5 titre ">Login In</h3>
      <form className="space-y-6" onSubmit={handleLoginSubmit}>
        <div>
          <label for ="email" className="input"> Your email</label>
          <input type="email" name="email" id="email" className="data" placeholder="name@company.com" required/>
        </div>
        <div>
          <label for ="password" className="input"> Password</label>
          <input type="password" name="password" id="password" className="data" placeholder="........."required/>
        </div>
        <button type="submit" className=" hover:bg-blue-800 confirmation">Log in </button>
      </form>
      </div>
    
    </Connexion>
    <Connexion isVisible={showModal2} onClose ={() =>setShowModal2(false)}> 
    <div className="py-6 px-6 lg:px-8 text-left">
      <h3 className="text-xl  mb-5 titre">Sign Up</h3>
      <form className="space-y-6" onSubmit={handleSignUpSubmit}>
  <div>
    <label htmlFor="fullname" className="input"> Full Name</label>
    <input type="text" name="fullname"id="fullname" className="data" 
    value={fullname} onChange={(e) => setFullname(e.target.value)} required/>
  </div>
  <div>
    <label htmlFor="email" className="input"> Your email </label>
    <input
      type="email" name="email"id="email" className="data" placeholder="name@company.com"
      value={email} onChange={(e) => setEmail(e.target.value)}required />
  </div>
  <div>
    <label htmlFor="phone" className="input"> Your Number Phone </label>
    <input
      type="number" name="phone"id="phone"className="data"placeholder="0123456789"
      value={phoneNumber} onChange={(e) => setPhoneNumber(e.target.value)}required />
  </div>
  <div>
    <label htmlFor="password" className="input"> Password </label>
    <input
      type="password" name="password" id="password" className="data"placeholder="........."
      value={password} onChange={(e) => setPassword(e.target.value)} required />
  </div>
  <div>
    <label htmlFor="conPassword" className="input"> Confirm Password</label>
    <input
      type="password"name="conPassword"id="conPassword"className="data"placeholder="........."
      value={conPassword} onChange={(e) => setConPassword(e.target.value)} required />
  </div>
  <button type="submit" className="hover:bg-blue-800 confirmation">Confirm </button>
</form>
      </div>
    
    </Connexion>
    </>
    
    </body>
     
    </html>
    </Fragment>
  );
}
