import Link from "next/link";
import Image from "next/image";
import image from '../../public/assets/image.png';
import '@/styles/roadmap/style-roadmaps.css'
import {UserIcon} from "@/components/utils/icons";
import '@/styles/roadmap/icon.css'


const Navbar = () => {
  const navStyle = {
    fontFamily: "lato",
    fontSize: "17px",
    marginTop: "10px",
    display: "flex",
    alignItems: "center",
    borderBottom: "1px outset white",
    backgroundColor: "rgba(0, 0, 0, 0.1)",
    marginTop: "0px"
  };

  const buttonStyle = {
    backgroundColor: "#7E22CE",
    width: "70px",
    height: "30px",
    borderRadius: "5px",
    marginBottom: "10px",
    marginTop: "10px"
  };

  return (
    <nav style={navStyle}>
      <div style={{ flex: "1", marginLeft: "15px" }}>
        <Image
          src={image}
          alt=""
          style={{ width: "50px", height: "auto" ,display:'inline'}}
        />
        <Link style={{ margin: "20px", marginLeft: "6px" }}  className="ma" href="/connect">
          Roadmap
        </Link>
      </div>
      <div style={{ flex: "1", textAlign: "center" }}>
        <Link style={{ margin: "17px"  }} className="ma" href="/">
          Home
        </Link>
        <Link style={{ margin: "17px" ,textDecoration:"none"}} className="ma" href="/connect">
          Roadmaps
        </Link>
      </div>
      <div style={{ flex: "1", textAlign: "right", marginRight: "15px"}}>
      <Link href="/dash" >
      <UserIcon className="usei" /></Link>
      </div>
    </nav>
  );
};

export default Navbar;
