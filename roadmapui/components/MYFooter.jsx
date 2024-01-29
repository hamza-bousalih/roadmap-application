"use client"

import { color } from 'framer-motion';
import React from 'react';

const Footer = () => {
  return (
    <footer className=" text-white p-8">
      <div className="container mx-auto">


        <div className="mb-8 text-center">
          <h3 className="text-xl font-semibold mb-4 text-purple-600">Roadmap Website</h3>
          <p>
           The Roadmap Website is a platform designed to provide roadmaps that guide individuals in self-discovery,
            offering them opportunities to explore and understand themselves better.
          </p>
        </div>

        <div className="text-center">
          <p>&copy; {new Date().getFullYear()} Roadmap Website. Tous droits réservés.</p>
        </div>
      </div>
    </footer>
  );
};

export default Footer;
