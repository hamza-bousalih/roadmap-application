import Link from "next/link";
import '@/styles/roadmap/style-roadmaps.css'
import {HomeIcon} from "@/components/utils/icons";
import {UserIcon} from "@/components/utils/icons";



const Navbar1 = () => {
  

  return (
    <>
   <div className="nav1">
   <div style={{ flex: "1"}}>
   <Link  href="/" >
      <HomeIcon className="mal"/></Link>
      </div>
      <div style={{ flex: "1", textAlign: "right", marginRight: "15px"}}>
      
      
      </div>
      <div style={{ flex: "1", textAlign: "right", marginRight: "15px" }}>
      
      <Link className="username" href="#" >
        username
         
      </Link>
      <UserIcon  className="mal"/>
     
      
    </div>

   </div>
  
  
  

    </>
    
  );
};

export default Navbar1;
