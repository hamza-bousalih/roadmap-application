"use client"
import { React , useState } from 'react';
import Link from "next/link";
import Image from "next/image";
import logo from '../public/assets/5-removebg-preview.png'
import {AiOutlineMenu} from 'react-icons/ai';

const NavBar = ({ setShowModal, setShowModal2 }) => {
   
    const [menuOpen , setMenuOpen] = useState(false);

    const handleNav = () => {
        setMenuOpen(!menuOpen);
    }

    const navStyle = {
        fontFamily: "lato",
        borderBottom: "1px outset #ccc", 
    };

    const buttonStyle = {
        backgroundColor: "#7E22CE",
        width: "100px",
        height: "30px",
        borderRadius: "5px",
        textAlign: "center",
    };
   
    return(
        <nav className="w-full shadow-xl">
            <div className="flex justify-between items-center h-20 px-4">
                <div className="flex items-center">
                    <Link href="/connect" style={{ color: "white", textDecoration: 'none' }}>
                        <div style={{ display: "flex", alignItems: "center" }}>
                            <Image
                                src={logo}
                                alt="logo"
                                width="95"
                                height="75"
                                className="cursor-pointer"
                                priority
                            />
                            <span>Roadmap</span>
                        </div>
                    </Link>
                </div>

                <div className="sm:hidden">
                    <div onClick={handleNav} className="cursor-pointer">
                        <AiOutlineMenu size={25}/>
                    </div>
                </div>

                <div className={`hidden sm:flex justify-center flex-1 ${menuOpen ? 'block' : 'hidden'}`}>
                    <ul className="flex justify-center">
                        <Link href="/">
                            <li className="ml-10 hover:border-b text-xl text-white">Home</li>
                        </Link>
                        <Link href="/roadmaps">
                            <li className="ml-10 hover:border-b text-xl text-white">Roadmaps</li>
                        </Link>
                    </ul>
                </div>

                <div className="hidden sm:flex">
                    <ul className="flex">
                        
                    <li style={{ ...buttonStyle }} className="ml-10 hover:border-b text-xl text-white">
                        <button onClick={() => setShowModal(true)}>Login In</button>
                    </li>
                        
                    
                    <li style={{ ...buttonStyle }} className="ml-10 hover:border-b text-xl text-white">
                        <button onClick={() => setShowModal2(true)}>Sign Up</button>
                    </li>
                        
                    </ul>
                </div>
            </div>
        </nav>
    )
}

export default NavBar;
