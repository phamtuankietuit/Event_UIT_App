import React from 'react';
import { SafeAreaView } from "react-native-safe-area-context";
import { Button, FlatList, Image, Text, TouchableOpacity, View } from "react-native";
import logo from "../../assets/images/Logo.png"
import { FontAwesomeIcon } from '@fortawesome/react-native-fontawesome';
import {
  faAngleRight,
  faArrowRightFromBracket,
  faPencil
} from '@fortawesome/free-solid-svg-icons';
export default function Profile() {
  return (
    <SafeAreaView className='flex-1'>
      <View className="text-wrap flex items-center flex-row gap-5 px-10">
        <Image
          source={logo}
          className="bg-white rounded-full w-[80px] h-[80px] me-4 "
        />
        <View>
          <Text className='font-semibold mb-2'>Ngô Trung Quân</Text>
          <Text>036537535</Text>
        </View>
        <TouchableOpacity>
          <FontAwesomeIcon icon={faPencil} />
        </TouchableOpacity>
      </View>

      <View className='px-10 my-7'>
        <TouchableOpacity className='rounded-lg w-[100%] bg-[#3A57E8] py-5 px-3 mb-3 flex justify-between flex-row items-center'>
          <Text className='text-white'>Quản lý sự kiện tham gia</Text>
          <FontAwesomeIcon icon={faAngleRight} color='white' />
        </TouchableOpacity>
        <TouchableOpacity className='rounded-lg w-[100%] bg-[#3A57E8] py-5 px-3 mb-3 flex justify-between flex-row items-center'>
          <Text className='text-white'>Điểm rèn luyện</Text>
          <FontAwesomeIcon icon={faAngleRight} color='white' />
        </TouchableOpacity>
        <TouchableOpacity className='rounded-lg w-[100%] bg-[#3A57E8] py-5 px-3 mb-3 flex justify-between flex-row items-center'>
          <Text className='text-white'>Quản lý sự kiện</Text>
          <FontAwesomeIcon icon={faAngleRight} color='white' />
        </TouchableOpacity>
        <TouchableOpacity className='rounded-lg w-[100%] bg-[#3A57E8] py-5 px-3 mb-3 flex justify-between flex-row items-center'>
          <Text className='text-white'>Báo cáo thống kê</Text>
          <FontAwesomeIcon icon={faAngleRight} color='white' />
        </TouchableOpacity>
        <TouchableOpacity className='rounded-lg w-[100%] bg-[#3A57E8] py-5 px-3 mb-3 flex justify-between flex-row items-center'>
          <Text className='text-white'>Đăng xuất</Text>
          <FontAwesomeIcon icon={faArrowRightFromBracket} color='white' />
        </TouchableOpacity>
      </View>
    </SafeAreaView>
  );
}
