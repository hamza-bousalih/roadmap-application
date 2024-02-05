"use client"
import Form from '@/components/form/form'
import Navbar from '@/components/navbar/navbar'
import Loader from "@/components/roadmap/laoder/Loader";
import {LookIcon} from "@/components/utils/icons";
import Service from "@/services"
import Link from 'next/link'
import {useEffect , useState} from "react";


export default function roadmap() {
    const [roadmaps , setRoadmap] = useState([]);
    const [loading , setLoading] = useState(true);

    useEffect(() => {
        const fetchData = async () => {
            try {
                const data = await Service.RoadmapService.findAll();
                setRoadmap(data);
                setLoading(false);
                console.log('Fetched Roadmap:' , data);
            } catch (error) {
                console.error('Error fetching roadmap:' , error);
            }
        };
        fetchData().catch(err => console.log(err));
    } , []);

 const comments = roadmaps.map((comm)  => (
      

  <div className="box" >
  <div className='card-body'>
  <LookIcon className="ico" />
  <Link href="/roadmaps/[id]" as={`/roadmaps/${comm.id}`} key={comm.id}>
    <h5 className='card-title text-white ' style={{textDecoration:'none',fontSize:'30px',fontWeight:'bold'}}>{comm.title}</h5>
    </Link>

    <p className='card-text' style={{color:'gray'}}>
      {comm.description}
    </p>
    <div style={{marginTop:'20px'}}>

      <span  className='tag'>Card link</span>
      <span  className='tag'>Card link</span>

    </div>

  </div>
</div>


 )
)
return <main>
<Navbar />
<div className= {`mt-4`}>

<div>
<Form/>


<div >
<div className='container'>

{comments}
</div>
</div></div></div></main>}
