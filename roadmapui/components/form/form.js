import Link from "next/link";
import Image from "next/image";
import image from '../../public/assets/image.png';
import '@/styles/roadmap/style-roadmaps.css'
import {SearchIcon} from "@/components/utils/icons";

const form = () => {
  return (
   <>
   <div className="enligne"><SearchIcon className="IcoSearch"/>
    <input type="search"  className="fo"  placeholder='tap here to search' /></div>
    
 
   </>
  );
};

export default form;
