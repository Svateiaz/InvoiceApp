import { useEffect, useState } from 'react';
import './App.css';

function App() {
    const [users, setUsers] = useState([]); // State to hold user data

    useEffect(() => {
        populateUserData(); // Fetch user data when the component mounts
    }, []);

    // Function to fetch user data from the API
    async function populateUserData() {
        try {
            const response = await fetch('https://localhost:7015/api/User'); // Adjust the URL if needed
            if (!response.ok) {
                throw new Error('Network response was not ok');
            }
            const data = await response.json();
            setUsers(data); // Set the fetched user data to state
        } catch (error) {
            console.error('There was a problem with the fetch operation:', error);
        }
    }

    // Render loading or user data
    // Flavia was here
    const contents = users.length === 0
        ? <p><em>Loading... Please refresh once the ASP.NET backend has started.</em></p>
        : (
            <table className="table table-striped" aria-labelledby="tableLabel">
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Username</th>
                    </tr>
                </thead>
                <tbody>
               
                    {users.map(user => (
                        <tr key={user.id}>
                            <td>{user.id}</td>
                            <td>{user.username}</td>
                        </tr>
                    ))}
                </tbody>
            </table>
        );

    return (
        <div>
            <h1 id="tableLabel">User List</h1>
           
            <p>This component demonstrates fetching user data from the server by Flavia.</p>
            {contents}
        </div>
    );
}

export default App;
