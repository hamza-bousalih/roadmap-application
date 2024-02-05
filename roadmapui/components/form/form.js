import Link from "next/link";
import Image from "next/image";
import image from '../../public/assets/image.png';
import '@/styles/roadmap/style-roadmaps.css'
import { SearchIcon } from "@/components/utils/icons";
import React, { useState, useEffect } from 'react';
import Search from "@/components/Search";

const form = () => {
  const [query, setQuery] = useState('');
  const [roadmap, setRoadmap] = useState([]);
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState(null);
  const [showModal, setShowModal] = useState(false);

  const fetchData = async () => {
    setLoading(true);

    try {
      const response = await fetch(`http://localhost:5265/api/roadmap/search/${query}`);
      const data = await response.json();

      if (response.ok) {
        setRoadmap(data);
        console.log('Fetched Roadmap:', data);
      } else {
        setError(data); // You might want to handle error data appropriately
        console.error('Error fetching roadmap:', data);
      }
    } catch (error) {
      setError(error);
      console.error('Error fetching roadmap:', error);
    } finally {
      setLoading(false);
    }
  };

  useEffect(() => {
    // You might want to fetch data when the component mounts or when the query changes
    // fetchData();
  }, [query]);

  const handleSearchClick = () => {
    fetchData();
    setShowModal(true); // Utiliser setShowModal pour montrer le modal
  };

  return (
    <>
      <div className="enligne">
        <button onClick={handleSearchClick}><SearchIcon className="IcoSearch" /></button>
        <input type="search" className="fo" value={query} onChange={(e) => setQuery(e.target.value)} placeholder="Search Roadmap" />
      </div>
      <Search isVisible={showModal} onClose={() => setShowModal(false)}>
        <div className="space-y-6">
        <div className="ind container">
      {roadmap.map((item) => (
        <div className="box" ><div key={item.id}  >
        <Link href={`/roadmaps/${item.id}`}>
            
                <h3 className="title">{item.title}</h3>
             
            </Link>
        <p  className="desc">{item.description}</p>
       
      </div></div>
      ))}</div>
          <p >Contenu du modal</p>
        </div>
      </Search>
      
    </>
  );
};

export default form;
