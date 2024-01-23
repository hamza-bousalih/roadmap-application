"use client"

import Slider from "react-slick";
import "slick-carousel/slick/slick.css";
import "slick-carousel/slick/slick-theme.css";
import down from '@/public/assets/Group 66.png';
import Image from "next/image";
import Service from "@/services"
import Link from 'next/link'
import "../styles/styleHome.css";
import React, { useEffect, useState } from "react";
import {LookIcon} from "@/components/utils/icons";

export default function MySlider() {
  const [roadmaps, setRoadmap] = useState([]);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    const fetchData = async () => {
      try {
        const data = await Service.RoadmapService.findAll();
        setRoadmap(data);
        setLoading(false);
        console.log('Fetched Roadmap:', data);
      } catch (error) {
        console.error('Error fetching roadmap:', error);
      }
    };
    fetchData().catch(err => console.log(err));
  }, []);

  const settings = {
    dots: true,
    infinite: false,
    speed: 500,
    slidesToShow: 3,
    slidesToScroll: 3,
    initialSlide: 0,
    responsive: [
      {
        breakpoint: 1024,
        settings: {
          slidesToShow: 2,
          slidesToScroll: 2,
          infinite: true,
          dots: true,
        },
      },
      {
        breakpoint: 600,
        settings: {
          slidesToShow: 2,
          slidesToScroll: 2,
          initialSlide: 2,
        },
      },
      {
        breakpoint: 480,
        settings: {
          slidesToShow: 1,
          slidesToScroll: 1,
        },
      },
    ],
  };

  const comments = roadmaps.map((comm) => (
    <div className='slid'>
    <div className="" key={comm.id} >
      <div className='card'>
      <div className="icon"  >
    <Image
       src={down}
       alt=""
       
    />
  </div>
      <LookIcon  className="icon"/>
        <Link href="/roadmaps/[id]" as={`/roadmaps/${comm.id}`} key={comm.id}>
          <h5 className="card-top">{comm.title}</h5>
        </Link>
        <p className="card-bottom" >
          {comm.description}
        </p>
        <div className='tags' >
              <button className='tag'>tag 1</button>
              <button className='tag'>tag 2</button>
              <button className='tag'>tag 2  tage 1</button>  
            </div>
      </div>
    </div>
    </div>
  ));

  return (
          <div>
            <Slider {...settings}>
              {comments}
            </Slider>
          </div>
  );
}
