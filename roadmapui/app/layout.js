import '@/styles/fonts.css'
import '@/styles/colors.css'
import '@/styles/globals.css'

export const metadata = {
    title: 'Roadmap Website',
    description: 'Discover curated courses, chart a clear path, and unlock knowledge\'s possibilities on our user-friendly roadmap to personalized learning success.\n',
}

export default function RootLayout({children}) {
    return (
        <html lang="en">
        <body>
        {children}
        </body>
        </html>
    )
}
