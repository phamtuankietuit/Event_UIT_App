import React from 'react';
import { Text, TouchableOpacity, View, Image } from "react-native"
import { format } from 'date-fns';
import logo from "../../assets/images/anhtruong.jpg"
import { FontAwesomeIcon } from '@fortawesome/react-native-fontawesome';
import {
    faTrash
} from '@fortawesome/free-solid-svg-icons';
function Event_Item({
    item,
    deleteItem
}) {
    return (
        <TouchableOpacity className='flex-row p-1 items-center mx-2  rounded-lg my-[5px] h-[90px] bg-white' style={{
            shadowColor: "#000",
            shadowOffset: {
                width: 0,
                height: 2,
            },
            shadowOpacity: 0.23,
            shadowRadius: 2.62,

            elevation: 4,
        }}>
            <View className="h-[100%] text-wrap w-[25%] flex items-center justify-center">
                <Image
                    source={logo}
                    className="bg-white w-[85%] h-[85%] me-4 rounded-[3px]"
                />
            </View>
            <View className='flex-1 mr-3'>
                <Text numberOfLines={2} className='font-semibold mb-3'>
                    Seminar nghiên cứu khoa học về AI cùng UIT, hãy tham gia để có các phần quà thú vị
                </Text>
                <Text className='text-xs'>
                    Thời gian {format(new Date(), 'dd/MM/yyyy - HH:mm')}
                </Text>
            </View>
            <TouchableOpacity className='flex justify-center items-center mr-2'>
                <View className='bg-red-400 p-3 rounded-full'>
                    <FontAwesomeIcon icon={faTrash} color='white' />
                </View>
            </TouchableOpacity>
        </TouchableOpacity>
    );
}

export default Event_Item;