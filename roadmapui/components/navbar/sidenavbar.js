import '@/styles/roadmap/style-roadmaps.css'
import {UserIcon} from "@/components/utils/icons";
import {LookIcon} from "@/components/utils/icons";
import {GearIcon} from "@/components/utils/icons";
import {ClockIcon} from "@/components/utils/icons";
import {RoadmapIcon} from "@/components/utils/icons";
import '@/styles/roadmap/icon.css'
const SideNavbar = () => {
  

  return (
    <>
   <div className="sidenavbar">
  <div className="sidenavbar-header">
    <h2>Roadmap</h2>
    <div className="horizontale"><hr></hr></div>
  </div>
  
  
  <ul className="sidenavbar-list">
    <li><RoadmapIcon className="icondash"/> <span></span><a href="/roadmaps">Roadmaps</a></li>
    <li><UserIcon className="icondash" /><a href="#">Profile</a></li>
    <li><ClockIcon className="icondash"/><a href="#">Activities</a></li>
    <li><LookIcon className="icondash"/><a href="#">Saved</a></li>
    <li><GearIcon className="icondash"/><a href="#">Settings</a></li>
  </ul>
</div>


    </>
    
  );
};

export default SideNavbar;
