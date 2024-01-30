"use client"
import React, { useState } from 'react';
import "@/styles/search.css"


const Search = ({isVisible ,onClose , children}) => {
 if ( !isVisible) return null;
 const handlClose =(e) =>{
    if(e.target.id === 'wrapper') onClose();
}


 return(
   <div className=' fixed inset-0 bg-black bg-opacity-25 backdrop-blur-sm flex justify-center items-center'id='wrapper' onClick={handlClose}>
        <div className=' md:w-[600px] w-[900px] mx-auto flex flex-col'>
            <button className='text-white text-xl place-self-end' onClick={() =>onClose()}>
                    X
            </button>
            <div className='bg-white p-2 rounded connexion'>
                    {children}
            </div>
        </div>
   </div> 
 )
}
export default Search